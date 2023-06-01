function MyFunction()
{
    var date=new Date();
    var day=date.getDay();
   
    var week=["sunday","monday","tuesday","wednesday","thursday","friday","saturday"];
    document.getElementById('week').innerHTML="Today is "+week[day];
    var hour=date.getHours();
    var min=date.getMinutes();
    var sec=date.getSeconds();
    var ex=hour>12 ? "PM" : "AM";
    document.getElementById('res').innerHTML="Current time is:" +hour+ex+" :"+min+" :"+sec;

}