PROTOCOL_DEFINITION=./etp/src/Schemas/etp.avpr

source: $(PROTOCOL_DEFINITION)
	rm -Rf Energistics
	./etp/build/bin/avrogen -p $< .

$(PROTOCOL_DEFINITION): etp

content:
	rm -Rf ./nuget/content/*
	cp -R ./etp/src/Schemas/* ./nuget/content

etp:
	git submodule update  --remote	

library: source	
	csc /target:library /out:nuget/lib/ETP.Messages.dll /reference:Avro.dll /lib:g:\usr\local\bin /recurse:*.cs	

package: library content
	cd nuget & nuget pack ETP.nuspec & cd ..
	
publish: package
	cd nuget & nuget setApiKey 4d9228fd-aea7-4cbe-8f55-2cf178f7b2c2 & cd ..
	cd nuget & nuget push ETP.1.0.4-alpha.nupkg & cd ..
	
.PHONY: source content library

.SUFFIXES: .cs .avsc .avpr
