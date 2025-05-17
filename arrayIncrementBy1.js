let num = [9,9]
for(let i=num.length-1;i>=0;i--)
{
    
    if(num[i] == 9 && i==0)
    {
        num[i] = 0;
        num.unshift(1);
    }
    else if(num[i] == 9)
    {
        num[i] = 0;
    }
    else{
        num[i] += 1;
        break;
    }
}

console.log(num)