\ Don't use this, include timer.fs
library librt rt.so.1
librt clock_gettime int ptr (int) clock_gettime
: sns ( -- seconds nanoseconds )
   0 0 sp@ 0 swap clock_gettime -21 ?throw swap ;
: nstime ( -- d)
   sns >r 1000000000 m* r> m+ ;
nstime
