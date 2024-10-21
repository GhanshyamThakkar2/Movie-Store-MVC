# Movie-Store-MVC
clone the project

open `appsettings.json` file and update connection string's `data source=your server name`
"ConnectionStrings": {
       "conn": "data source=your_server_name;initial catalog=MovieStoreMvc; integrated security=true;encrypt=false"
}


Add `Migrations` folder
Open Tools > Package Manager > Package manager console
Run these 2 commands

(i) add-migration init
(ii) update-database

Now you can run this project

Q) How to Register as a admin and login?
Ans) There is a controller "UserAuthentication" and a commented method "Register". Uncomment the "Register" method
     Run the project and hit the url "https://localhost:7095/UserAuthentication/Register". You will be registered as a admin. Now you can re 
     comment the register user (for privacy).
     Now you can login with credentials "Username: admin, password: Admin@123"
