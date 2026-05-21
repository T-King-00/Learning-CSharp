console.log("hello this is a practice project")
/*
document.cookie = "name=John Doe;expires=Fri, 31 Dec 2026 23:59:59 GMT;";
document.cookie = "email=Tony_r@x.com;expires=Fri, 31 Dec 2026 23:59:59 GMT;";
document.cookie = "language=csharp;expires=Fri, 31 Dec 2026 23:59:59 GMT; ";
console.log(document.cookie)
document.cookie="name=John Doe; expires=Fri, 31 Dec 2000 23:59:59 GMT;"
*/
function SetCookie(){
    let target=document.getElementById("textForCookie")
    let textValue=target.value;
    
    document.cookie=`textValue=${textValue}; expires=Fri, 31 Dec 2026 23:59:59 GMT;`;
    console.log("cookie saved + text is "+ textValue);
}

function GetCookie(){
    const firstText=document.querySelector("#textForCookie");
    firstText.value=document.cookie.split("=")[1];
    console.log(document.cookie.split("=")[1])
    
}
document.cookie="language=csharp; expires=Fri, 31 Dec 2000 23:59:59 GMT;"
