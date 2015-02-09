//自适应Iframe对话框
function autoHeight(iframeObj) {

    if (document.getElementById) {
        if (iframeObj) {
            if (iframeObj.contentDocument && iframeObj.contentDocument.body.offsetHeight) {
                //iframeObj.style.height = iframeObj.contentDocument.body.offsetHeight;
                iframeObj.height = Math.min(iframeObj.contentDocument.body.scrollHeight, iframeObj.contentDocument.documentElement.scrollHeight);//iframeObj.contentDocument.body.offsetHeight + 30;
       
            } else if (document.frames[iframeObj.name].document && document.frames[iframeObj.name].document.body.scrollHeight) {
                //iframeObj.style.height = document.frames[iframeObj.name].document.body.scrollHeight;

                iframeObj.height = Math.min(iframeObj.contentDocument.body.scrollHeight, iframeObj.contentDocument.documentElement.scrollHeight); //document.frames[iframeObj.name].document.body.scrollHeight + 30;
                

            }
        }
    }
}