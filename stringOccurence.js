let haystack = "busadtsad"
let needle = "sad"
for(let i = 0; i<haystack.length;i++){
    if(haystack.substr(i,needle.length) === needle)
    {
        console.log(i)
        break
    }
    if(i==haystack.length-needle.length){
    console.log(-1)
}   
}
