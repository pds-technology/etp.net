copy [energistics schemas] to [content]

compile [energistics c# source code] to ETP.Messages.dll

copy [ETP.Messages.dll] to [lib]

nuget.exe setApiKey 4d9228fd-aea7-4cbe-8f55-2cf178f7b2c2

nuget pack ETP.nuspec

-- should change this based on the nuspec version
nuget.exe push ETP.1.0.0.nupkg

