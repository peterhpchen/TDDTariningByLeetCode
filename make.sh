#!/bin/bash
# 自動建置題目所需類別及測試程式

read -p "請輸入題號： " number
read -p "請輸入題目名稱： " name

# 建立題目資料夾
mkdir LeetCode.No${number}.${name}
cd LeetCode.No${number}.${name}

# 建立資料夾, README
mkdir Solution
mkdir Solution.Test
touch README.md

# 建立dotnet類別專案
cd Solution
dotnet new classlib
mv Class1.cs Solution.cs

# 建立dotnet測試專案
cd ../Solution.Test
dotnet new xunit
mv UnitTest1.cs UnitTest.cs
dotnet add reference ../Solution/Solution.csproj

# 將題目專案加入至sln
cd ../../
dotnet sln add LeetCode.No${number}.${name}/Solution/Solution.csproj
dotnet sln add LeetCode.No${number}.${name}/Solution.Test/Solution.Test.csproj