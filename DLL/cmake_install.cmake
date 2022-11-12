# Install script for directory: C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5

# Set the install prefix
if(NOT DEFINED CMAKE_INSTALL_PREFIX)
  set(CMAKE_INSTALL_PREFIX "C:/Program Files/libiec61850")
endif()
string(REGEX REPLACE "/$" "" CMAKE_INSTALL_PREFIX "${CMAKE_INSTALL_PREFIX}")

# Set the install configuration name.
if(NOT DEFINED CMAKE_INSTALL_CONFIG_NAME)
  if(BUILD_TYPE)
    string(REGEX REPLACE "^[^A-Za-z0-9_]+" ""
           CMAKE_INSTALL_CONFIG_NAME "${BUILD_TYPE}")
  else()
    set(CMAKE_INSTALL_CONFIG_NAME "Release")
  endif()
  message(STATUS "Install configuration: \"${CMAKE_INSTALL_CONFIG_NAME}\"")
endif()

# Set the component getting installed.
if(NOT CMAKE_INSTALL_COMPONENT)
  if(COMPONENT)
    message(STATUS "Install component: \"${COMPONENT}\"")
    set(CMAKE_INSTALL_COMPONENT "${COMPONENT}")
  else()
    set(CMAKE_INSTALL_COMPONENT)
  endif()
endif()

# Is this installation the result of a crosscompile?
if(NOT DEFINED CMAKE_CROSSCOMPILING)
  set(CMAKE_CROSSCOMPILING "FALSE")
endif()

if("x${CMAKE_INSTALL_COMPONENT}x" STREQUAL "xDevelopmentx" OR NOT CMAKE_INSTALL_COMPONENT)
  file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/include/libiec61850" TYPE FILE FILES
    "C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5/hal/inc/hal_base.h"
    "C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5/hal/inc/hal_time.h"
    "C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5/hal/inc/hal_thread.h"
    "C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5/hal/inc/hal_filesystem.h"
    "C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5/hal/inc/hal_ethernet.h"
    "C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5/hal/inc/hal_socket.h"
    "C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5/hal/inc/tls_config.h"
    "C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5/src/common/inc/libiec61850_common_api.h"
    "C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5/src/common/inc/linked_list.h"
    "C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5/src/iec61850/inc/iec61850_client.h"
    "C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5/src/iec61850/inc/iec61850_common.h"
    "C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5/src/iec61850/inc/iec61850_server.h"
    "C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5/src/iec61850/inc/iec61850_model.h"
    "C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5/src/iec61850/inc/iec61850_cdc.h"
    "C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5/src/iec61850/inc/iec61850_dynamic_model.h"
    "C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5/src/iec61850/inc/iec61850_config_file_parser.h"
    "C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5/src/mms/inc/mms_value.h"
    "C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5/src/mms/inc/mms_common.h"
    "C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5/src/mms/inc/mms_types.h"
    "C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5/src/mms/inc/mms_type_spec.h"
    "C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5/src/mms/inc/mms_client_connection.h"
    "C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5/src/mms/inc/mms_server.h"
    "C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5/src/mms/inc/iso_connection_parameters.h"
    "C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5/src/goose/goose_subscriber.h"
    "C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5/src/goose/goose_receiver.h"
    "C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5/src/goose/goose_publisher.h"
    "C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5/src/sampled_values/sv_subscriber.h"
    "C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5/src/sampled_values/sv_publisher.h"
    "C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5/src/logging/logging_api.h"
    )
endif()

if("x${CMAKE_INSTALL_COMPONENT}x" STREQUAL "xUnspecifiedx" OR NOT CMAKE_INSTALL_COMPONENT)
  file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/bin" TYPE PROGRAM FILES
    "C:/Program Files/Microsoft Visual Studio/2022/Community/VC/Redist/MSVC/14.31.31103/x64/Microsoft.VC143.CRT/msvcp140.dll"
    "C:/Program Files/Microsoft Visual Studio/2022/Community/VC/Redist/MSVC/14.31.31103/x64/Microsoft.VC143.CRT/msvcp140_1.dll"
    "C:/Program Files/Microsoft Visual Studio/2022/Community/VC/Redist/MSVC/14.31.31103/x64/Microsoft.VC143.CRT/msvcp140_2.dll"
    "C:/Program Files/Microsoft Visual Studio/2022/Community/VC/Redist/MSVC/14.31.31103/x64/Microsoft.VC143.CRT/msvcp140_atomic_wait.dll"
    "C:/Program Files/Microsoft Visual Studio/2022/Community/VC/Redist/MSVC/14.31.31103/x64/Microsoft.VC143.CRT/msvcp140_codecvt_ids.dll"
    "C:/Program Files/Microsoft Visual Studio/2022/Community/VC/Redist/MSVC/14.31.31103/x64/Microsoft.VC143.CRT/vcruntime140_1.dll"
    "C:/Program Files/Microsoft Visual Studio/2022/Community/VC/Redist/MSVC/14.31.31103/x64/Microsoft.VC143.CRT/vcruntime140.dll"
    "C:/Program Files/Microsoft Visual Studio/2022/Community/VC/Redist/MSVC/14.31.31103/x64/Microsoft.VC143.CRT/concrt140.dll"
    )
endif()

if("x${CMAKE_INSTALL_COMPONENT}x" STREQUAL "xUnspecifiedx" OR NOT CMAKE_INSTALL_COMPONENT)
  file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/bin" TYPE DIRECTORY FILES "")
endif()

if(NOT CMAKE_INSTALL_LOCAL_ONLY)
  # Include the install script for each subdirectory.
  include("C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5/Built/hal/cmake_install.cmake")
  include("C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5/Built/examples/cmake_install.cmake")
  include("C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5/Built/src/cmake_install.cmake")

endif()

if(CMAKE_INSTALL_COMPONENT)
  set(CMAKE_INSTALL_MANIFEST "install_manifest_${CMAKE_INSTALL_COMPONENT}.txt")
else()
  set(CMAKE_INSTALL_MANIFEST "install_manifest.txt")
endif()

string(REPLACE ";" "\n" CMAKE_INSTALL_MANIFEST_CONTENT
       "${CMAKE_INSTALL_MANIFEST_FILES}")
file(WRITE "C:/Users/sebas/OneDrive - Universite De Technologie De Belfort-Montbeliard/8. BR04/TO54/Lib-Code Source/LIB RENDU/libiec61850-1.5/Built/${CMAKE_INSTALL_MANIFEST}"
     "${CMAKE_INSTALL_MANIFEST_CONTENT}")
