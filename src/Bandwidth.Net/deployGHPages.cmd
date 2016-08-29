@echo off
if not defined BRANCH (
    set BRANCH=master
)
if not defined APPVEYOR_REPO_BRANCH (
    exit 1
)  
if not %APPVEYOR_REPO_BRANCH% == %BRANCH% (
    exit 1
)
rd /s /q Help Pages
%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe Bandwidth.Net.Html.shfbproj
git clone https://github.com/bandwidthcom/csharp-bandwidth.git Pages
cd Pages
git checkout gh-pages || git checkout -b gh-pages
git rm -rf .
xcopy ..\Help\* . /s /q
git add .
set COMMIT_MESSAGE=Updated API docs
if  defined APPVEYOR_PULL_REQUEST_TITLE (
    set COMMIT_MESSAGE=%COMMIT_MESSAGE%: %APPVEYOR_PULL_REQUEST_TITLE%
)
git commit -m "%COMMIT_MESSAGE%"
git push origin gh-pages
cd ..