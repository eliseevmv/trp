

    Ideally I would like to clarify requirements before writing code. For example, I would check the range of supported characters
    (ASCII, extended ASCII or Unicode). I would also check what characters can be considered to be a part of a word.

    I would also clarify requirements for treatment of nulls, empty strings and strings without words. 

    I would also double-check why the function should return both word and its length. It is very unusual because in C# it is trivial
    to get the length of a string (by calling .Length getter). It would be natural if the function only returned a string (the longest word). 

    I would also look at coding standards in the system, any external systems which use the results of this method,
    and discussed it with the colleagues.
    
    It is a coding test and (I assume) it is not possible to clarify the requirements. Therefore I have made a number of assumptions.

    - Only extended ASCII symbols are supported
    - Words can only consist of letters defined by C# char.IsLetter function.
        (Note that as a consequence, HTML5 and King's would not be considered words)
    - If an argument is null, the function will throw an exception
    - If an argument is an empty string, the function will return null and 0
    - If an argument is a string without letters, the function will return null and 0
    - I assume that there are requirements which explain why the function must return both the word and its length
    - I assume that if there two equally long words, the function can return any of them 

    I have also considered merging 
              
    