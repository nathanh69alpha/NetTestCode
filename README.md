# NetTestCode
demo ef code for .Net framework apps

When you open the solution you may get a message you don't have the necessary Target .Net Framework installed. There should be a link there enabling you to install the Target Framework. (this app uses version 4.8)

Need Nuget package EntityFramework version 6.4.4 (do no use the Core version)

before running code:
 1. Go to Tools > Nuget Package Manager > Package Manage Console
 2. at the PM> prompt type "enable-migrations" and press Enter (if you get a message saying it's already been enabled go to step 3
 3. at the PM> prompt type "update-database" and press Enter, when done you'll see an empty PM> prompt
 4. Close Package Manager Console
 5. Run the application (this will seed the db with sample data *see the Page_Load method in Default.aspx.cs)
 6. in the Default.aspx.cs file in Page_Load comment out the SeedDb() statement (you won't need it anymore, db has been seeded with data)
