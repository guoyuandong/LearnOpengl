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

message("EXTERNAL_LIBS 的值是: ${EXTERNAL_LIBS}")
target_link_libraries(triangle PRIVATE ${EXTERNAL_LIBS})