# Use the specified base image
FROM ironsoftwareofficial/ironpdfengine:2023.8.6

# Create the directory for fonts if it does not exist
RUN mkdir -p /usr/share/fonts/

# Copy all fonts from the local fonts directory to the container's font directory
COPY fonts/ /usr/share/fonts/

# Change the permissions of the fonts to be accessible
RUN chmod 644 /usr/share/fonts/*

RUN fc-cache -fv
