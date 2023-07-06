import { ECategoryType } from "../../ECategoryType";

class bookSearchPayload {
    public category: ECategoryType;
    public keyword: string;

    constructor(category: ECategoryType, keyword: string){
        this.category = category;
        this.keyword = keyword;
    }   
}

export { bookSearchPayload };