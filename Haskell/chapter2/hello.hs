main = putStrLn "Hello StackBuilders"



ifibonacci :: Integer -> Maybe Integer
ifibonacci n = if n < 0
               then Nothing
               else case n of
                     0 -> Just 0
                     1 -> Just 1
                     n -> let Just f1 = ifibonacci (n-1)
                              Just f2 = ifibonacci (n-2)
                          in Just (f1 + f2)



factorial :: Integer -> Integer  
factorial n = product [1..n] 


