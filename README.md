## Billion Bank Web Application
This web application provides the clients of Billion Bank the ability to do secure online banking. Clients are able to register their profile before opening multiple accounts. Clients are given R100 once they open their first account. Further functionality includes the ability to transfer funds between accounts and updating personal information and login password.

## Motivation
In today's tech savvy world, online banking has become a requirement for any bank wanting to keep up with top competitors in the industry. This is exactly why this web application was developed - to provide Billion Bank with the infrastructure to keep up with their clients' needs.

## Code Style
[![js-standard-style](https://img.shields.io/badge/code%20style-standard-brightgreen.svg?style=flat)](https://github.com/feross/standard)

## Tech/Frameworks Used
- [ASP.NET MVC](https://dotnet.microsoft.com/apps/aspnet/mvc)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-2019)
- [Bootstrap](https://getbootstrap.com/)

## Features
- User register and login
- Open multiple accounts
- Transfer funds between accounts
- View transfer history per account
- Update profile information and password

## Web Services
The following web services are used in this application:
- Add Client, adding registered users to the Client table.
- Add Account, adding newly opened accounts to the Accounts table.
- Add Transaction, add each transfer to the Transactions table.
- Deduct Account, deducts the specified account's balance when a transfer is made.
- Increase Account, increase the specified account's balance when a transfer is made.
- Update Profile, updates the user's profile information.

## Getting Started
- In the Database folder, add the database file to your running SQL Server instance.
- Next, from the Web Services folder, open each web service project and update the connection strings by using your own Server name.
- Now, run each web service locally.
- Finally, in the Application/ProjectMVP folder, update the connection strings within the application by using your own Server name

## How To Use?
- Once the application is running in your browser, go ahead and register your new profile on the Register page.
- Next, you would need to open at least two accounts in order to transfer funds between them.
- Now, go to the Transfer page, provide the 'To Account' number, 'From Account' number and 'Amount' of the transfer to complete your first transaction. 
- Afterwards, you will be able to view the transaction on the Accounts page by clicking on the View Transactions button.
- Transfers are written to a log file named 'TransactionLog.csv', which will be stored in you pc's Documents folder after the first transfer.
- You are also able to update your profile information and password by clicking on your username which is displayed as your email address at the top of the page. Please note that all fields are required when updating your profile information.
- Lastly, you can log out of your profile before logging back in.

## Current Issues
- Users can only transfer integer values, e.g R102 and not decimal or double amounts such as R102,10.

## Author
- [Christiaan Venter](https://www.github.com/codecventer)
