list(APPEND EXTERNAL_INCLUDES
  ${CMAKE_CURRENT_LIST_DIR}/include
)

# add_library(glad ${CMAKE_CURRENT_LIST_DIR}/src/glad.c)
# set_target_properties(glad PROPERTIES LINKER_LANGUAGE C)

list(APPEND EXTERNAL_SOURCES
  ${CMAKE_CURRENT_LIST_DIR}/src/glad.c
)