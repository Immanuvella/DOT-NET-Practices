function MyFunction()
{
    var date=new Date();
    var day=date.getDate();
    var month=date.getMonth()+1;
    var year=date.getFullYear();
    var ex=date<10 ? '0'+day : day;
    var ex2=month<10? '0'+month :  month;
    document.getElementById('res').innerHTML=ex+"/"+ex2+"/"+year;
}

function RotateFun()
{
    var res=document.getElementById('input').innerHTML;
    for(let i=0;i<res.length;i++){
       var rot=res.push(res[i]);
       document.getElementById('input').innerHTML=rot;
       var pop=res.pop();
        document.getElementById('input').innerHTML=pop;
    }
  
}