cmake_minimum_required(VERSION 3.23)

project(
  LearnOpengl
  VERSION 1.0
  LANGUAGES C CXX)

include(${CMAKE_CURRENT_LIST_DIR}/external/CMakeLists.txt)

message("EXTERNAL_INCLUDES 的值是: ${EXTERNAL_INCLUDES}")
include_directories(${EXTERNAL_INCLUDES})

add_executable(triangle ${CMAKE_CURRENT_LIST_DIR}/src/01_triangle/main.cpp ${EXTERNAL_SOURCES})

message("EXTERNAL_LIBS 的值是: ${EXTERNAL_LIBS}")
target_link_libraries(triangle PRIVATE ${EXTERNAL_LIBS})