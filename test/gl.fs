require test/aw.fs
require gl.fs
require fixed.fs


: square ( size -- )
  >r GL_POLYGON glBegin
      r@ negate r@ negate glVertex2f
      r@ negate r@ glVertex2f
      r@ r@  glVertex2f
      r@ r@ negate glVertex2f
  glEnd rdrop ;

: <int> parse-word s>number , ;

: color: create <int> <int> <int> <int> does> glColor4uiv ;

color: fg -1  -1  0  0

:noname
   fx# 1 fx# 0 fx# 0 fx# 1 glClearColor
   GL_COLOR_BUFFER_BIT GL_DEPTH_BUFFER_BIT or glClear
   fx# -1 fx# 1 fx# -1 fx# 1 fx# -1 fx# 1 glOrtho
   fg fx# 0.5 square
; is draw

:noname
   >r 0 0 r> 2@ swap glViewport
; is resize

