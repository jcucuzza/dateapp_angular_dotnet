## Date Apes ##
------
Dev log:

- Develop Client side login and registration within Angular 8.

- ~~Authentication- creating a user model, authentication controller, tokens, and middleware and stuffs.~~

- ~~create a skeleton template to get a functional http responses to and from .Net and Angular.~~

-----

Current Folder structure:

| Folder | Description |
| ------ | ------ |
| dateapp.api  | .Net [back-end]|
| dateapp-spa |  Angular 8 [front-end] |

----
Currently running on seperate domains:


| Folder | Port |
| ------ | ------ |
| dateapp.api  | 5000 |
| dateapp-spa |  4200 |

----

Clone Repo (need to have angular8, node v10, .Net framework, Sqlite)

```sh
$ git clone https://github.com/jcucuzza/dateapp_angular_dotnet.git 
$ cd dateapp-spa
$ npm install
```

Start Angular app

```sh
$ cd dateapp-spa
$ ng serve
```


Start .Net api

```sh
$ cd ../dateapp-spa
$ dotnet watch run
```
