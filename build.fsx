#r "paket:
nuget Fake.Core.Target //"
// include Fake modules, see Fake modules section

open System.IO
open Fake.Core
open Fake.IO
open System

// TODO: reintroduce semantic versioning


let buildArtifactPath = Path.getFullName("./build_artifacts")
let packagesPath = Path.getFullName( "./src/packages")
let keyFile = Path.getFullName( "./Machete.snk")

let assemblyVersion = "1.0.0.0"
let baseVersion = "1.0.0"

let envVersion = (Fake.Core.Environment.environVarOrDefault "APPVEYOR_BUILD_VERSION" (baseVersion + ".0"))
let buildVersion = (envVersion.Substring(0, envVersion.LastIndexOf('.')))

//let semVersion : SemVerInfo = SemVer.parser(buildVersion)

let Version = "1.0.0"

let branch = (fun _ ->
  (Fake.Core.Environment.environVarOrDefault "APPVEYOR_REPO_BRANCH" (getBranchName "."))
)

let FileVersion = (Fake.Core.Environment.environVarOrDefault "APPVEYOR_BUILD_VERSION" (Version + "." + "0"))

let informationalVersion = (fun _ ->
  let branchName = (branch ".")
  let label = if branchName="master" then "" else " (" + branchName + "/" + (getCurrentSHA1 ".").[0..7] + ")"
  (FileVersion + label)
)

let nugetVersion = (fun _ ->
  let branchName = (branch ".")
  let label = if branchName="master" then "" else "-" + (branchName)
  let version = if branchName="master" then Version else FileVersion
  (version + label)
)

let InfoVersion = informationalVersion()
let NuGetVersion = nugetVersion()

let versionArgs = [ @"/p:Version=""" + NuGetVersion + @""""; @"/p:PackageVersion=""" + NuGetVersion + @""""; @"/p:AssemblyVersion=""" + FileVersion + @""""; @"/p:FileVersion=""" + FileVersion + @""""; @"/p:InformationalVersion=""" + InfoVersion + @"""" ]

printfn "Using version: %s" Version

// *** Define Targets ***
Target.create "Clean" (fun _ ->
  Trace.log " --- Cleaning stuff --- "
)

Target.create "Build" (fun _ ->
  Trace.log " --- Building the app --- "
)

Target.create "Deploy" (fun _ ->
  Trace.log " --- Deploying app --- "
)

open Fake.Core.TargetOperators

// *** Define Dependencies ***
"Clean"
  ==> "Build"
  ==> "Deploy"

// *** Start Build ***
Target.runOrDefault "Deploy"