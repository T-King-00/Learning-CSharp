const apiCall=async (url,options)=>
{
    try {
        var response=await fetch(url,options);
        if (!response.ok){
            throw Error(response.statusText)

        }
    }
    catch (e) {
        console.error(e);
    }
    
    const result=await response.json();
    
    
    return result;


};

let url="https://weatherbit-v1-mashape.p.rapidapi.com/forecast/3hourly?lat=35.5&lon=-78.5&units=imperial&lang=en";
const options={
    method:"GET",
    headers: {
        'x-rapidapi-key': 'bf276fc7d0msh22637b87fad20f7p1d70fajsn515f78d31490',
        'x-rapidapi-host': 'weatherbit-v1-mashape.p.rapidapi.com',
        'Content-Type': 'application/json'
        
    }
}

let r=await apiCall(url,options );
console.log(r)