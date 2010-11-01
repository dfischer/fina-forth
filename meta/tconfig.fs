\ Convert target cells to bytes
: tcells ( u -- u')
   tcellbits 8 / * ;

64        tcells constant /pad     \ Pad size
64        tcells constant /tib     \ Terminal Input Buffer size
64        tcells constant /hld     \ HOLD buffer size
64        tcells constant /user    \ Space reserved for user variables
256       tcells constant /ds      \ Data stack size
256       tcells constant /rs      \ Return stack size
64 1024 * tcells constant /tdict   \ Dictionary size

