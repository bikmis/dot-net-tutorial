How to create WCF Service Library

- Right-click on the solution and add a project of "WCF Service Library" template.
- Add an interface (with ServiceContract, DataContract, DataMember etc) and implement it. 
- Right-click on the project and click on Properties and then WCF Options. You may uncheck the following if you want to not run WCF Service Host (this hosts a service for debugging/testing purpose during development)
   "Start WCF Service Host when debugging another project in the same solution"

