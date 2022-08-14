var myApp = myApp || {};

//myApp.triggerAlert = (message) => {
//    alert(message);
//};

myApp.triggerAlert = (forecast) => {
    alert("forecast temp : " + forecast.temperatureC);
};
