How to create a WCF Service:

- Right-click on the solution and add a new project of "WCF Service" template.
- WCF Service is a website template. To rename this website you need to rename it in .vs/solution_name/config/applicationhost.config at the element <site name="Change the name here..." id="..."></site>
- Create an interface INameService.cs in the App_Code folder and implement the interface with "NameService.cs""
- Add a new file Name.svc with the following code.
	<%@ ServiceHost Language="C#" Debug="true" Service="NameService" CodeBehind="~/App_Code/NameService.cs" %>
- Create a bin folder and add two files (*.dll and *.pdb) from the WcfServiceLibrary and add a *.svc file and add config in the web.config
- Add the following in web.config
<system.serviceModel>
    <diagnostics performanceCounters="Default" />
    <behaviors>
      <serviceBehaviors>
        <behavior name="mexBehavior">
          <!-- To avoid disclosing metadata information, set the values below to false before deployment -->
          <serviceMetadata httpGetEnabled="true"/>
          <!-- To receive exception details in faults for debugging purposes, set the value below to true.  Set to false before deployment to avoid disclosing exception information -->
          <serviceDebug includeExceptionDetailInFaults="false"/>
        </behavior>
      </serviceBehaviors>
    </behaviors>
    <services>
      <service behaviorConfiguration="mexBehavior" name="NameService">
        <endpoint address="NameService" binding="basicHttpBinding" name="NameService"
          contract="INameService" />
      </service>
      <service behaviorConfiguration="mexBehavior" name="MyWcfServiceLibrary.WriterService">
        <endpoint address="WriterService" binding="basicHttpBinding" name="WriterService"
          contract="MyWcfServiceLibrary.IWriterService" />
      </service>
    </services>
    <protocolMapping>
      <add binding="basicHttpsBinding" scheme="https"/>
    </protocolMapping>
    <serviceHostingEnvironment aspNetCompatibilityEnabled="true" multipleSiteBindingsEnabled="true"/>
</system.serviceModel>
