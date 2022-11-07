FROM mcr.microsoft.com/devcontainers/dotnet:0-6.0-bullseye

USER vscode

RUN dotnet dev-certs https --trust
RUN dotnet dev-certs https -ep "${HOME}/.aspnet/https/aspnetapp.pfx" -p "password1"
