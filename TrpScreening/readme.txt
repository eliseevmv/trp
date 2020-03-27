

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
