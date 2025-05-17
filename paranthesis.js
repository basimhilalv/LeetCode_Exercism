let string = "()[]{}"
let status = 0;
for(let i=0; i<string.length;i++){
    if(string[i] == "("){
        for(let j = i; j<string.length;j++){
            if(string[j] == ")")
            {
                status = 1;
            }
        }
    }
}