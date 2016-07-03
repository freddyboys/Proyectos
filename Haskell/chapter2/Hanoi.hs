main = putStrLn "Torres de Hanoi"


hanoi :: Integer -> a -> a -> a -> [(a, a)]
hanoi 0 _ _ _ = []
hanoi n a b c = hanoi (n-1) a c b ++ [(a,b)] ++ hanoi (n-1) c b a

hanoiIO n = mapM_ f $ hanoi n 1 2 3 where
  f (x,y) = putStrLn $ "Mover " ++ show x ++ " hacia" ++ show y