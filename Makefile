PROTOCOL_DEFINITION=./etp/src/Schemas/etp.avpr
VERSION=1.4.1
BUILD=0
BUILDPREFIX=.
PACKAGE=ETP.$(VERSION)$(BUILDPREFIX)$(BUILD)
source: $(PROTOCOL_DEFINITION)
	rm -Rf Energistics
	./etp/build/bin/avrogen -p $< .
	find ./Energistics -name "*.cs" | sed s/\\//\\\\/g > csc.rsp
	echo ".\Properties\AssemblyInfo.cs" >> csc.rsp

$(PROTOCOL_DEFINITION): etp

content:
	rm -Rf ./nuget/content/*
	cp -Rp ./etp/src/Schemas/* ./nuget/content/

etp:
	git submodule update  --remote	
	cd etp && git pull origin master && git checkout HEAD && make && cd ..	

library: source	etp.snk
	bash fill_templates.sh $(VERSION) $(BUILDPREFIX) $(BUILD) $(PACKAGE)
	csc /warn:4 /target:library /out:nuget/lib/ETP.Messages.dll /reference:Avro.dll /lib:./etp/build/bin /keyfile:etp.snk @csc.rsp

package: library content
	cd nuget && nuget pack $(PACKAGE).nuspec && cd ..
	
publish: package
	cd nuget && nuget setApiKey 4d9228fd-aea7-4cbe-8f55-2cf178f7b2c2 && cd ..
	cd nuget && nuget push $(PACKAGE).nupkg && cd ..
	git tag -a $(VERSION)$(BUILDPREFIX)$(BUILD) -m 'PUBLISH $(VERSION)$(BUILDPREFIX)$(BUILD) to NUGET'
	git push --tags
	
etp.snk:
	sn -k etp.snk
	
.PHONY: source content library etp

.SUFFIXES: .cs .avsc .avpr
