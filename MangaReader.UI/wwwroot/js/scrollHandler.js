//window.scrollHandler = () => {
//    DotNet.invokeMethodAsync('App', 'OnScroll');
//};
//window.addEventListener('scroll', scrollHandler);


//window.onDivScroll = (elem) => {
//    console.log(e)
//    alert("scroll");
//    elem.addEventListener('scroll', function (e) {
//        console.log(e)
//        alert("scroll");
//        DotNet.invokeMethodAsync('OnScroll', e);
//    });
//}
//window.addEventListener('scroll', window.onDivScroll);
//window.addEventListener('scroll', function (e) {
//    console.log(e)
//    alert("win scroll", e);
//    DotNet.invokeMethodAsync('OnScroll', e);
//});
//function onDivScroll(elem) {
//    console.log(elem)
//    alert("scroll", elem);
//}


//var blazorHybrid = blazorHybrid || {};
//blazorHybrid.onScroll = (event) => {
//    // Call back into .NET method to handle the event
//    DotNet.invokeMethodAsync('OnScroll', event);
//};



window.scrollCallback = (element) => {
    DotNet.invokeMethodAsync('MangaReader', 'OnScroll');
};

function registerScroll(element) {
    element.addEventListener('scroll', () => scrollCallback(element));
}