// Open Window
function openWindow(baseUri, page, target, windowFeatures) {
    const baseUriString = baseUri;
    const pageString = page;

    // Window open parameters
    // 1 - url
    let url = "";
    if (!isEmpty(baseUriString) && !isEmpty(pageString))
        url = baseUriString + pageString;

    // 2 - target
    const targetString = target; // The target parameter determines which window or tab to load the resource into

    // 3 - windowFeatures
    const windowFeaturesString = windowFeatures;

    window.open(url, targetString, windowFeaturesString);
}

function isEmpty(value) {
    return (value == null || (typeof value === "string" && value.trim().length === 0));
}
