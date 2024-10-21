# Movie-Store-MVC
clone the project

1) open `appsettings.json` file and update connection string's `data source=your server name`
2) "ConnectionStrings": {
       "conn": "data source=your_server_name;initial catalog=MovieStoreMvc; integrated security=true;encrypt=false"
   }


3) Add `Migrations` folder
4) Open Tools > Package Manager > Package manager console
5) Run these 2 commands

6) (i) add-migration init
   (ii) update-database

7)  Now you can run this project

8)  Q) How to Register as a admin and login?

    Ans) There is a controller "UserAuthentication" and a commented method "Register". Uncomment the "Register" method
         Run the project and hit the url "https://localhost:7095/UserAuthentication/Register". You will be registered as a admin. Now you             can re comment the register user (for privacy). Now you can login with credentials "Username: admin, password: Admin@123"
