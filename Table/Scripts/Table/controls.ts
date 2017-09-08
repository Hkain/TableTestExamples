module controls {

    interface IdatePickerProps extends React.Props<any>, React.HTMLAttributes
    {
        id: string,
        dateValue?: Date,
        onDateChanged: (d: Date) => any;
    }

    class DatepickerClass extends React.Component<IdatePickerProps, {}>
    {

    }

    interface ILinesProps extends React.Props<any>
    {
        id: number;
        text?: string;
        date?: Date;
        onTextChanged: (id: number, text: string) => void;

    }

    class LineClass extends React.Component<ILineProps, {}>
    {
        constructor(props?: ILineProps, context?: any)
    }

    export function Lines()
    {
        return React.createElement(LinesClass, props, {});
    }

}