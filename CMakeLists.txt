cmake_minimum_required(VERSION 3.23)

project(
  LearnOpengl
  VERSION 1.0
  LANGUAGES C CXX)

include(${CMAKE_CURRENT_LIST_DIR}/external/CMakeLists.txt)

message("EXTERNAL_INCLUDES 的值是: ${EXTERNAL_INCLUDES}")
include_directories(${EXTERNAL_INCLUDES})

set(UTilS_INCLUDES ${CMAKE_CURRENT_LIST_DIR}/src/utils)
include_directories(${UTilS_INCLUDES})

set(UTilS_SOURCES)
aux_source_directory(${CMAKE_CURRENT_LIST_DIR}/src/utils UTilS_SOURCES)

add_executable(triangle ${CMAKE_CURRENT_LIST_DIR}/src/01_triangle/main.cpp ${EXTERNAL_SOURCES} ${UTilS_SOURCES})
add_executable(shader_class ${CMAKE_CURRENT_LIST_DIR}/src/02_shader_class/main.cpp ${EXTERNAL_SOURCES} ${UTilS_SOURCES})
add_executable(texture ${CMAKE_CURRENT_LIST_DIR}/src/03_texture/main.cpp ${EXTERNAL_SOURCES} ${UTilS_SOURCES})
add_executable(transformations ${CMAKE_CURRENT_LIST_DIR}/src/04_transformations/main.cpp ${EXTERNAL_SOURCES} ${UTilS_SOURCES})
add_executable(coordinateSystems ${CMAKE_CURRENT_LIST_DIR}/src/05_coordinateSystems/main.cpp ${EXTERNAL_SOURCES} ${UTilS_SOURCES})

set_target_properties(triangle shader_class texture transformations coordinateSystems PROPERTIES VS_DEBUGGER_WORKING_DIRECTORY "$(TargetDir)")

message("EXTERNAL_LIBS 的值是: ${EXTERNAL_LIBS}")
target_link_libraries(triangle PRIVATE ${EXTERNAL_LIBS})
target_link_libraries(shader_class PRIVATE ${EXTERNAL_LIBS})
target_link_libraries(texture PRIVATE ${EXTERNAL_LIBS})
target_link_libraries(transformations PRIVATE ${EXTERNAL_LIBS})
target_link_libraries(coordinateSystems PRIVATE ${EXTERNAL_LIBS})