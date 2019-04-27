# Sonic '06 Toolkit
Sonic '06 Toolkit is an application originally written in VB.NET to help make modding easier for SONIC THE HEDGEHOG (2006). Now being written in C#, Sonic '06 Toolkit has been made open-source to allow the community to contribute to the project.

# Project Goals
Because this is a complete rewrite, the goal is to include everything that was in the VB.NET version so users aren't missing out on the original features.

### ARC Unpacking and Repacking (done)
- Yes, the key features to at least modify the contents of the archives.

### LUB Decompiling (needs work)
- Sonic '06 Toolkit currently uses a Java-based Lua decompiler. It would be more beneficial to write a Lua decompiler in C, rather than depending on Java as a requirement.

### XNO Converting (done) and XNM Pairing
- Likely using the same method as last time to convert these files, but improving XNM pairing as it can be rather tedious.

### ADX Encoding
- Planned features to add tools for encoding and decoding ADX files for sound modding.

### MST Decoding
- Planned features to decode MST files, which are BINA string tables with null terminated unicode.