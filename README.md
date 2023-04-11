# Login-and-Register-System
Login and Register System using C# for Windows Forms

<p align="center">
  <a href="#-technologies">Technologies</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-how-to-use">How to use</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-license">License</a>
</p>
<div align="center" style="margin: 20px; text-align: center">

  [![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](https://github.com/BinaryLeo/Login-and-Register-System/blob/main/LICENSE)
  ![GitHub last commit](https://img.shields.io/github/last-commit/BinaryLeo/Login-and-Register-System?style=flat-square)
  ![GitHub top language](https://img.shields.io/github/languages/top/BinaryLeo/Login-and-Register-System?style=flat-square)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-Functional-green)


</div>

<div align="center"><img src="https://user-images.githubusercontent.com/72607039/156090075-28dbf5fc-0420-4992-bab8-b6e49125e1de.gif" width=50% height=50%></div>

## 🧪 technologies

This project was built using the following technologies and features:

- C#
- [PostgreSQL](https://www.postgresql.org/)
- [NpgSql](https://www.npgsql.org/)
- [Visual Studio IDE](https://visualstudio.microsoft.com)

## 💡 how to use

- Clone the repository.
- Open the project from Visual Studio 2022.
- Rename the file from <code>APP_config.xml</code> to <code>app.config</code> and in the below code section type your database credentials.


```bash
<appSettings>
		<add key="MyConnection" value="Server=localhost;Port=5432;Database=yourDataBase;User Id=postgres;Password=yourPassword;" />
	</appSettings>
```
                                                                                               

- Database structure.

For this application, we are using A local PostgreSQL Database. 
 
  Table name : csharp_user
  
   
``` sql
create TABLE IF NOT EXISTS csharp_user(
    id Serial ,
    username VARCHAR NOT NULL,
    password VARCHAR NOT NULL,
    PRIMARY KEY (id)
)
```

``` sql
INSERT into csharp_user(username,password) values('admin', 'admin') 
```

![system](https://user-images.githubusercontent.com/72607039/156093419-6378d936-b20a-409e-8b63-ffe97b781f3f.png)

## 📄 License

This project was built under MIT. See the file [LICENSE](LICENSE) for more details.

---
