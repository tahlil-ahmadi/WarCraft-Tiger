#tool "nuget:?package=xunit.runner.console"
#tool "nuget:?package=JetBrains.dotCover.CommandLineTools"

Task("Clean")
    .Does(()=>{
        CleanDirectories("../Code/**/bin/Debug");
        CleanDirectories("../Code/**/obj/Debug");
});

Task("Restore-Nuget")
    .Does(()=> {
        NuGetRestore("../Code/WarCraft-Tiger.sln");
});

Task("Build")
    .Does(()=>{
        MSBuild("../Code/WarCraft-Tiger.sln", configurator =>
            configurator.SetConfiguration("Debug")
                .SetVerbosity(Verbosity.Minimal)
                .UseToolVersion(MSBuildToolVersion.VS2015)
                .SetMSBuildPlatform(MSBuildPlatform.x86)
                .SetPlatformTarget(PlatformTarget.MSIL));
});

Task("Run-Unit-Tests")
    .Does(()=>{
       //var testAssemblies = GetFiles("../Code/**/bin/Debug/*.Tests.Unit.dll");
       //XUnit2(testAssemblies);
       DotCoverCover(tool => {
            tool.XUnit2("../Code/**/bin/Debug/*.Tests.Unit.dll",
                new XUnit2Settings {
                ShadowCopy = false
                });
            },
        new FilePath("./TestResults/result.dcvr"),
        new DotCoverCoverSettings());

        DotCoverReport(new FilePath("./TestResults/result.dcvr"),
            new FilePath("./TestResults/result.html"),
            new DotCoverReportSettings {
                ReportType = DotCoverReportType.HTML
        });
});

Task("Default")
    .IsDependentOn("Clean")
    .IsDependentOn("Restore-Nuget")
    .IsDependentOn("Build")
    .IsDependentOn("Run-Unit-Tests");

RunTarget("Default");