

    Ideally I would like to clarify requirements before writing code. For example, I would check the range of supported characters
    (ASCII, extended ASCII or Unicode). I would also check what characters can be used considered to be part of a word.

    I have made the following assumptions in order to simplify this excercise:
    - Only ASCII symbols are supported
    - Words can only consist of letters


    I have assumed that 

        Alternative implementation
        - return just a string
        - return a Tuple instead of WordWithLength

        null and empty string - assumption; it would be easier to make decision if I knew the context, coding standards in the system,  
        how the external code is going to use this method; discuss it with the colleagues

        no letters - same as empty string

        Separators - depends on the system and requirements. It could be all non-alphanumeric characters in ASCII, could be a subset.
        It could include selected or all non-alphanumeric Unicode characters.
        
        

        non-ascii letters, non-ascii non-letters
        Words with numbers
        Long numbers
