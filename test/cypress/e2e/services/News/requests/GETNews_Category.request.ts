/// <reference types="cypress"/>

import { ECategoryType } from "../../ECategoryType";

function getNewsCategory(request: ECategoryType){
    return cy.request({
        method: 'GET',
        url: `News?category=${request}`,
        headers: { 'Accept-Language': 'en-us', },
        failOnStatusCode: false,
    });
}

export { getNewsCategory };