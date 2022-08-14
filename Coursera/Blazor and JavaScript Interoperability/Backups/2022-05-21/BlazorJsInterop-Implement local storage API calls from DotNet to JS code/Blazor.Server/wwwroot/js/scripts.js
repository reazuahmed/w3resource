var myApp = myApp || {};

//myApp.triggerAlert = (message) => {
//    alert(message);
//};

myApp.triggerAlert = (forecast) => {
    alert("forecast temp : " + forecast.temperatureC);
};

myApp.showPrompt = () => {
    return prompt('What is your name?')
};