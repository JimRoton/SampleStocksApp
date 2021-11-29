######################################################
# This is phase one of the StocksApi sample application.
# In this phase we will download and setup the base app,
# extend to include the StockManager. Add the Yahoo and
# REDIS services.
######################################################

# download the base stocks api
cd ~
mkdir Repos
cd Repos
git clone https://github.com/neudesic/dallas-tech-night.git

# test the api
cd dallas-tech-night\StocksApiBase
dotnet run
curl https://localhost:5001/Stocks/MSFT

# copy files from base
cp ..\dallas-tech-night\StocksApiBase\* . -Recurse
cp ..\dallas-tech-night\.gitignore .

# push stocksapi
git add --all
git commit -m "initial commit"
git push

# development
# groundwork
- Add Interfaces
- Add services
- Create Manager
- Wire up manager > services (startup)
- Test

# yahoo
- Add Yahoo model
- Finish YahooFinance services
- Test

# redis
- Get REDIS image
- Add REDIS package "dotnet add package StackExchange.Redis"
- Finish REDIS service
- Test