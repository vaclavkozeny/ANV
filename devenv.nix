{
  pkgs,
  lib,
  config,
  inputs,
  ...
}: {
  env.DEVSHELL_NAME = "devshell | JAVA";
  languages.java = {
    enable = true;
    jdk.package = pkgs.jdk25;
    maven.enable = true;
    gradle.enable = true;
  };
}
