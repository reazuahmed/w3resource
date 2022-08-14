//var myap;
            /*This variable is gonna have functions on it.
            "myApp" is now global variable and it's gonna be available on the window object of the browser.*/


/* "myApp.triggerAlert" is the path to the function(). We can use this in another page as well meaning anywhere within the project. */
//myApp.triggerAlert = function() {
//    aleHelloello')   /*globally available a on window object.ect.*/
//}

/*We can write the above function as follows:
 Let's say, just incase "myApp" already has been defined previously and I have already have some functions() on it, the 
 pattern to follow here would be I would set "myApp=myApp" if it exists. Or, if it doesn't exists, I will initialize it to an
 empty object as follows:
 */
var myApp = myApp || {};

/*Arrow-Syntax for function, which is now supported in the browser throughout and this is the arrow-syntax for a function.
 basically, we have the parameter, then the arrow points to the body of the function.
 Next step, I will jump in and trigger this function() from the Dotnet Code.*/
myApp.triggerAlert = () => {
    alert('Hello');
};