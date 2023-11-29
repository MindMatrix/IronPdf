# IronPdf

1. Build docker image with custom fonts, note that we also tried running the ironpdf container directly and using `docker cp` to copy the files as well
```shell
docker build docker -t ironpdf
```
1. Run IronPdf in docker
```shell
cd src
docker run -d --name=ironpdf -p 33350:33350 ironpdf
```