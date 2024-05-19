interface Book
{
    id: number;
    title: string;
    description: string;
    author: string;
    rate?: number;
    dateStart?: Date;
    dateRead? : Date;
}