How to create and run Angular application in .net 5 (.net core)

1. Install .NET Core Hosting Bundle (dotnet-hosting-5.0.1-win.exe). It installs the .NET Core Runtime and the 
   ASP.NET Core Module (to allow ASP.NET Core apps to run with IIS).

2. Right-click solution and add new project and select the template "ASP.NET Core Web Application", click Create 
   and select ASP.NET Core 5.0 and Angular.

3. Add the following web.config file at the ClientApp/src folder with url rewrite.
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <system.webServer>
    <rewrite>
      <rules>
        <rule name="Angular Rewrite Rule" stopProcessing="true">
          <match url=".*" />
          <conditions logicalGrouping="MatchAll">
            <add input="{REQUEST_FILENAME}" matchType="IsFile" negate="true" />
            <add input="{REQUEST_FILENAME}" matchType="IsDirectory" negate="true" />
          </conditions>
          <action type="Rewrite" url="/" />
        </rule>
      </rules>
    </rewrite>
  </system.webServer>
</configuration>

4. Change'/' to the IIS application name in "href" attribute of "base" element in index.html.

5. If already not installed, install URL Rewrite (https://www.iis.net/downloads/microsoft/url-rewrite). Create an application in IIS 
   and set its name (alias) to the project name. Create an app pool with project_name_app_pool. 
   Point the Physical Path to the folder of the project and set Application Pool to project_name_app_pool.
   Click on the application and double-click on Authentication and edit Anonymous Authentication and
   set Anonymous user identity to Application pool identity. Right-click on the application and Edit Permissions... At Security
   tab add IIS AppPool\project_name_app_pool to Group or user names box.

6. In Startup.cs change spa.UseAngularCliServer(npmScript: "start"); to spa.UseProxyToSpaDevelopmentServer("http://localhost:4200");
            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    // spa.UseAngularCliServer(npmScript: "start");
                    spa.UseProxyToSpaDevelopmentServer("http://localhost:4200");
                }
            });

7. Right-click on the project and Click on Properties and click on Debug. Click on New... and add a new profile "IIS", set Launch to IIS, 
   add name/value in Environment variables (name as ASPNETCORE_ENVIRONMENT and value as Development) and check Launch Browser.

8. Open PowerShell on ClientApp (Right-click on ClientApp and click on Open in Terminal) and run "npm start" 
   or "ng serve" at the prompt (the application will run at http://localhost:4200)

9. Change IIS Express to IIS and click F5 to start debugging in IIS or right-click on the Application in IIS and click on Manage 
   Application and then click on Browse.
