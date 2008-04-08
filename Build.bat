ncc -g -o NPhilosopher -t library CILReflector.n CILToStack.n CILCompileIA32.n
ncc -g -o nilc -t exe -r NPhilosopher NILC.n
