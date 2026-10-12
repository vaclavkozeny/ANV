{
  pkgs,
  lib,
  config,
  inputs,
  ...
}: {
  env.DEVSHELL_NAME = "devshell | C#";
  env.DOTNET_CLI_TELEMETRY_OPTOUT = "1";
  languages.dotnet = {
    enable = true;
    package = pkgs.dotnet-sdk_10;
  };
}
