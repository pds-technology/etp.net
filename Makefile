PROTOCOL_DEFINITION=./etp/src/Schemas/etp.avpr
VERSION=1.4.0
BUILD=0
BUILDPREFIX=.
PACKAGE=ETP.$(VERSION)$(BUILDPREFIX)$(BUILD)
GIT_HASH=`git rev-parse --verify HEAD`
source: $(PROTOCOL_DEFINITION)
	rm -Rf Energistics
	./etp/build/bin/avrogen -p $< .

$(PROTOCOL_DEFINITION): etp

content:
	rm -Rf ./nuget/content/*
	cp -Rp ./etp/src/Schemas/* ./nuget/content/

etp:
	git submodule update  --remote	
	cd etp & git pull origin master & cd ..

library: source	etp.snk
	bash fill_templates.sh $(BUILD)
	csc /target:library /out:nuget/lib/ETP.Messages.dll /reference:Avro.dll /lib:./etp/build/bin /recurse:Energistics/*.cs Properties/AssemblyInfo.cs /keyfile:etp.snk

package: library content
	sed -E 's/__VERSION__/$(VERSION)/' nuget/Template.nuspec | sed -E 's/__BUILD__/$(BUILDPREFIX)$(BUILD)/' > nuget/$(PACKAGE).nuspec
	cd nuget && nuget pack ETP.nuspec && cd ..
	
publish: package
	cd nuget && nuget setApiKey 4d9228fd-aea7-4cbe-8f55-2cf178f7b2c2 && cd ..
	cd nuget && nuget push $(PACKAGE).nupkg && cd ..
	git tag -a $(VERSION)-$(BUILD) -m 'PUBLISH $(VERSION)-$(BUILD) to NUGET'
	git push --tags
	
release: package
	cd nuget && nuget setApiKey 4d9228fd-aea7-4cbe-8f55-2cf178f7b2c2 && cd ..
	cd nuget && nuget push $(PACKAGE).nupkg && cd ..
	git tag -a $(VERSION)$(BUILDPREFIX)$(BUILD) -m 'PUBLISH $(VERSION)$(BUILDPREFIX)$(BUILD) to NUGET'
	git push --tags

etp.snk:
	sn -k etp.snk
	
.PHONY: source content library

.SUFFIXES: .cs .avsc .avpr
