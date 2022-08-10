# NetTestCode
demo ef code for .Net framework apps

*When you open the solution in Visual Studio you may get a message you don't have the necessary Target .Net Framework installed. There should be a link there enabling you to install the Target Framework. (this app uses version 4.8)

before running code:

1. Go to Tools > Nuget Package Manager > Package Manage Console *you may see a message saying you need to restore packages, click the Restore button
2. at the PM> prompt type "update-database" and press Enter, when done you'll see an empty PM> prompt
3. Close Package Manager Console
4. Run the application (this will seed the db with sample data *see the Page_Load method in Default.aspx.cs)
5. in the Default.aspx.cs file in Page_Load method comment out the SeedDb() statement (you won't need it anymore, db has been seeded with data)
