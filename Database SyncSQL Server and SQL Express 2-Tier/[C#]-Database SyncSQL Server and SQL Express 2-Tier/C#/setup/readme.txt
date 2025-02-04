� 2009 Microsoft Corporation.  All rights reserved.


SharingAppDemo - End-To-End SharingAppDemo Sample Application

This application demonstrates how to use Sync Framework database synchronization providers to configure and execute peer-to-peer synchronization between SQL Server or SQL Express databases.

What is Demonstrated in This Sample?

- Synchronizing a database scope with multiple instances of SQL Server/SQL Express databases.
- Enabling synchronization over a 2-tier model.
- The new multi-scope change-tracking model on the server.
- Configuration of SqlSyncProvider objects.
- Enabling batched synchronization.
 

How Do I Install the Application?

1- Connect to an instance of SQL Server, and open and execute peer1_setup.sql.
2- Open demo.sql and execute the "Insert Sample Data In Tables" sections at the top of the script.
3- In Visual Studio, open the SharingAppDemo-SqlProviderEndToEnd solution .
4- Build the project.


What Do the Individual CS Files Contain? 

App directory - Contains all the code files for the Windows Form app.
 App\SqlCreationUtilities.cs - Contains utility classes that the app uses to handle string constants and hold peer database information.
 App\SqlSharingForm.cs - Main entrance point for the Windows Form app. Contains all GUI eventing/OnClick logic. 
 App\NewSqlPeerCreationWizard.cs - New wizard app that is used to gather user information to configure and provision a new SQL Server or SQL Express database.
 App\ProgressForm.cs - Form app that shows progress information for each SyncOrchestrator.Synchronize() call.
 App\Resource.resx and App\Resources.Designer.cs - Resource files. 
 App\SharingApp.cs - Contains the Main function that launches a new instance of the SqlSharingForm class.
 App\SynchronizationHelper.cs - The main class that handles configuration SqlSyncProvider instances. Short instructions are included for each method in the class:
	CheckAndCreateSQLDatabase() - Utility function that creates an empty SQL Server database.
	CheckIfProviderNeedsSchema() - Sample that demonstrates how a SqlSyncProvider would determine if the underlying database needs a schema or not.
	ConfigureSqlSyncProvider() - Sample that demonstrates how to configure SqlSyncProvider.
	provider_*() - Sample client side event registration code that demonstrates how to handle specific events raised by Sync Framework.
 App\TablesViewControl.cs - Custom user control that displays values from the two sample tables (orders and order_details).
 
Setup directory - Contains the server provisioning .sql files.


How Do I Use the Sample?

1.  Install the application as described in the "How Do I Install" section.
2.  Run the sample app. It assumes that SQL Server is installed as localhost. If it's not, please replace Environment.MachineName with the correct instance name in SqlSharingForm.SqlSharingForm_Shown(). 
3.  If the sample is correctly installed, values from the orders and order_details tables should display in the datagrid on the "Peer1" tab.
4.  The Synchronize button is disabled until at least one new SQL Server peer is added. Add a new SQL Server database by clicking "Add SQL Peer". SQL Server can be on local or remote machines with Windows NT integrated security or the given username and password.
5.  On clicking OK, a new tab with the name "Peer#" should be added to the main form. After the peer is synchronized, clicking that tab displays values for the tables orders and order_details in that SQL Server database.
6.  Batching can be enabled by setting a non-zero value in the Batch size text box. By default batching is disabled.
6a. The Batching location can be modified by clicking on the Change button.
7.  To synchronize, select source and destination providers, and click Synchronize.
8.  Make changes to one or more database tables of different peers and then try to synchronize the peers to confirm that changes are synchronized.