How to create an application in IIS

Security in IIS:
1. The application's app pool is set to MyMVCAppWithDotNetAppPool.
2. Click on the application and double-click on Authentication. Right-click on Anonymous Authentication 
   and click on Edit... and change Anonymous user identity to Application pool identity.
3. Right-click on the application and click on Edit Permissions... and  click on Security, then click Edit and 
   then Add... Type in "IIS APPPOOL\MyMVCAppWithDotNetAppPool" in Enter the object names to select field and click Check Name and click OK.

Security in Sql server for IIS application:
1. In sql server add "IIS APPPOOL\MyMVCAppWithDotNetAppPool" to Security/Users (right-click on Users of the database in question, 
   click on New User... and Set User type to Windows user and put "IIS APPPOOL\MyMVCAppWithDotNetAppPool" in User name field. In Membership, 
   check db_owner).
2. In sql server add "IIS APPPOOL\MyMVCAppWithDotNetAppPool" to Security/Logins (right-click on Logins and click New Login... and put "IIS APPPOOL\MyMVCAppWithDotNetAppPool" in Login name field and click OK.)

