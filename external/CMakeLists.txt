set(EXTERNAL_LIBS)
set(EXTERNAL_INCLUDES)
set(EXTERNAL_SOURCES)

include(${CMAKE_CURRENT_LIST_DIR}/sources/CMakeLists.txt)

if(CMAKE_SYSTEM_NAME MATCHES "Windows")
    MESSAGE(STATUS "current platform: Windows ")
    include(${CMAKE_CURRENT_LIST_DIR}/win64/CMakeLists.txt)
endif()