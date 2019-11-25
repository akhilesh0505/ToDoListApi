Testing Urls:
/* Default Url to get List of all ToDoListObjects */
http://localhost:53572/api/ToDoList/

/* Url to get the list of all ToDoListObjects for a given user */
http://localhost:53572/api/ToDoList/GetToDoListByUser/?UserId=Akhilesh

/* Url to get the ToDoListObject for a given ID */
http://localhost:53572/api/ToDoList/GetToDoListById/?Id=1

/* Url to add a ToDoListObject to the repository*/
http://localhost:53572/api/ToDoList/AddToDoListObject
/* sample Json string for body to add ToDoListObject */
{
        "Description": "List for TestUser",
        "UserId": "TestUser",
        "ToDoListItems": [
            {
                "Description": "List Item1 for TestUser",
                "Status": false
            },
            {
                "Description": "List Item2 for TestUser",
                "Status": false
            }
        ]
 }

 /* Url to Update ToDoListObject for Given ID*/
 http://localhost:53572/api/ToDoList/UpdateToDoListObject?id=1
 /* sample Json string for body to Update ToDoListObject */
 {
        "Description": "List for TestUser2",
        "ToDoListItems": [
            {
                "ID": 1,
                "Description": "List Item1 for TestUser2",
                "Status": false
            },
            {
                "ID": 2,
                "Description": "List Item2 for TestUser2",
                "Status": false
            }
        ]
 }

 /* Url to delete ToDoListObject for Given ID*/
 http://localhost:53572/api/ToDoList/DeleteToDoListObject/1

 /* Url to retreive ToDoListItems for given ToDoListObject with Given ID*/
 http://localhost:53572/api/ToDoListItem/?ToDoListObjectId=3

 /* Url to add ToDoListItems for given ToDoListObject with Given ID*/
 http://localhost:53572/api/ToDoListItem/AddToDoListItem?ToDoListObjectId=1
 {
        "Description": "List Item3 for me",
        "Status": true
 }

 /* Url to update ToDoListItems for given ToDoListObject with Given ID*/
 http://localhost:53572/api/ToDoListItem/UpdateToDoListItem?ToDoListObjectId=1
 {
        "ID": 1,
        "Description": "List Item3 for me",
        "Status": true
 }

 /* Url to delete ToDoListItems for given ToDoListObject for Given ID */
 http://localhost:53572/api/ToDoListItem/DeleteToDoListItem?ToDoListObjectId=1&ToDoListItemID=3