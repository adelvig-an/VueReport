<template>
    <div class="container">
        <div class="row">
            <div class="col">
                <h6>Площадь, кв.м.</h6>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Общая</label>
                <input class="form-control" type="text" />
            </div>
            <div class="col">
                <label class="form-lable">С учетом летных помещений</label>
                <input class="form-control" type="text" />
            </div>
            <div class="col">
                <label class="form-lable">Жилая</label>
                <input class="form-control" type="text" />
            </div>
            <div class="col">
                <label class="form-lable">Кухни</label>
                <input class="form-control" type="text" />
            </div>
        </div>
        <div class="row">
            <div class="col">
                <div class="form-check">
                    <input class="form-check-input" type="checkbox" id="total-area">
                    <label class="form-check-label" for="total-area">
                        Использовать для расчета стоимости площадь вместе с летними помещениями
                    </label>
                </div>
            </div>
        </div>

        <!--
    Описание объекта оценки
    -->
        <div class="row">
            <div class="col">
                <h6>Описание объекта оценки</h6>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Количество комнат в квартире</label>
                <div class="row">
                    <div class="col">
                        <div class="btn-group" role="group">
                            <input type="radio" value="acceptable" name="radio-rooms" id="studio"
                                   class="btn-check" />
                            <label for="studio" class="btn btn-outline-primary">Студия</label>
                            <input type="radio" value="unacceptable" name="radio-rooms" id="room-1"
                                   class="btn-check" />
                            <label for="room-1" class="btn btn-outline-primary">1</label>
                            <input type="radio" value="sufficient" name="radio-rooms" id="room-2"
                                   class="btn-check" />
                            <label for="room-2" class="btn btn-outline-primary">2</label>
                            <input type="radio" value="excellent" name="radio-rooms" id="room-3"
                                   class="btn-check" />
                            <label for="room-3" class="btn btn-outline-primary">3</label>
                            <input type="radio" value="excellent" name="radio-rooms" id="room-4"
                                   class="btn-check" />
                            <label for="room-4" class="btn btn-outline-primary">4</label>
                            <input type="radio" value="excellent" name="radio-rooms" id="room-5"
                                   class="btn-check" />
                            <label for="room-5" class="btn btn-outline-primary">5</label>
                            <input type="radio" value="excellent" name="radio-rooms" id="room-multi"
                                   class="btn-check" />
                            <label for="room-multi" class="btn btn-outline-primary">Многокомнатная</label>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Высота потолков, м.</label>
                <input class="form-control" type="text" />
            </div>
            <div class="col">
                <label class="form-lable">Этаж размещения</label>
                <input class="form-control" type="text" />
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Тип планировки</label>
                <select class="form-select"></select>
            </div>
            <div class="col">
                <label class="form-lable">Тип комнат</label>
                <select class="form-select"></select>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <div class="btn-group" role="group">
                    <input type="radio" value="acceptable" name="radio-renovation" id="revealed"
                           class="btn-check" />
                    <label for="revealed" class="btn btn-outline-primary">Выявлено</label>
                    <input type="radio" value="unacceptable" name="radio-renovation" id="not-revealed"
                           class="btn-check" />
                    <label for="not-revealed" class="btn btn-outline-primary">Не выявлено</label>
                </div>
            </div>
            <div class="col">
                <div class="btn-group" role="group">
                    <input type="radio" value="acceptable" name="radio-legalize" id="there-legalize"
                           class="btn-check" />
                    <label for="there-legalize" class="btn btn-outline-primary">Присутствует</label>
                    <input type="radio" value="unacceptable" name="radio-legalize" id="not-there-legalize"
                           class="btn-check" />
                    <label for="not-there-legalize" class="btn btn-outline-primary">Отсутствует</label>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <div class="form-check">
                    <input class="form-check-input" type="checkbox" id="tgeokwap">
                    <label class="form-check-label" for="tgeokwap">
                        Перенос газового оборудования за пределы кухни без соответствующего разрешения
                    </label>
                </div>
                <div class="form-check">
                    <input class="form-check-input" type="checkbox" id="cgbp">
                    <label class="form-check-label" for="cgbp">
                        Изменение общих границ объекта недвижимости
                    </label>
                </div>
                <div class="form-check">
                    <input class="form-check-input" type="checkbox" id="ilatosahfncwtd">
                    <label class="form-check-label" for="ilatosahfncwtd">
                        Устройство лоджий и террас на вторых и выше этажах, которые не соответствуют техническим документам
                    </label>
                </div>
                <div class="form-check">
                    <input class="form-check-input" type="checkbox" id="trcchwssasp">
                    <label class="form-check-label" for="trcchwssasp">
                        Перенос подключенных к общедомовой системе горячего водоснабжения радиаторов отопления на площади летних помещений (балкон, лоджия)
                    </label>
                </div>
                <div class="form-check">
                    <input class="form-check-input" type="checkbox" id="fpdssb">
                    <label class="form-check-label" for="fpdssb">
                        Полный/частичный демонтаж несущей конструкции здания (за исключением подоконного блока)
                    </label>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Затраты на согласование/востановление</label>
                <input class="form-control" type="text" />
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Описание перепланировок</label>
                <textarea class="form-control" rows="5" />
                <div class="form-check">
                    <input class="form-check-input" type="checkbox" id="lbwna">
                    <label class="form-check-label" for="lbwna">
                        Несущие стены не затронуты
                    </label>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Конструктивные элементы</label>
                <div class="btn-group" role="group">
                    <input type="radio" value="acceptable" name="radio-structural-elements" id="specify"
                           class="btn-check" />
                    <label for="specify" class="btn btn-outline-primary">Указать</label>
                    <input type="radio" value="unacceptable" name="radio-structural-elements" id="not-specify"
                           class="btn-check" />
                    <label for="not-specify" class="btn btn-outline-primary">Не указывать</label>
                </div>
            </div>
        </div>
        <div class="row" style="background: #e1dede">
            <div class="col">
                <div class="row">
                    <div class="col">
                        <label class="form-lable">Полы</label>
                        <select class="form-select"></select>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <label class="form-lable">Описание</label>
                        <textarea class="form-control" rows="5" />
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <label class="form-lable">Потолок</label>
                        <select class="form-select"></select>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <label class="form-lable">Описание</label>
                        <textarea class="form-control" rows="5" />
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <label class="form-lable">Стены</label>
                        <select class="form-select"></select>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <label class="form-lable">Описание</label>
                        <textarea class="form-control" rows="5" />
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <label class="form-lable">Окна</label>
                        <select class="form-select"></select>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <label class="form-lable">Описание</label>
                        <textarea class="form-control" rows="5" />
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <label class="form-lable">Входная дверь</label>
                        <select class="form-select"></select>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <label class="form-lable">Описание</label>
                        <textarea class="form-control" rows="5" />
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <label class="form-lable">Межкомнатные двери</label>
                        <select class="form-select"></select>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <label class="form-lable">Описание</label>
                        <textarea class="form-control" rows="5" />
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Качество ремонта</label>
                <select class="form-select"></select>
            </div>
            <div class="col">
                <label class="form-lable">Санузел</label>
                <select class="form-select"></select>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Вид из окон</label>
                <select class="form-select"></select>
            </div>
            <div class="col">
                <label class="form-lable">Наличие балконов/лоджий</label>
                <select class="form-select"></select>
            </div>
            <div class="col">
                <label class="form-lable">Остекление балконов/лоджий</label>
                <select class="form-select"></select>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Система коммуникаций</label>
                <select class="form-select"></select>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Подключение коммункаций</label>
                <div class="row">
                    <div class="col">
                        <div class="btn-group" role="group">
                            <input type="radio" value="connected" name="radio-connecting-communication" id="connected"
                                   class="btn-check" />
                            <label for="connected" class="btn btn-outline-primary">Установленно</label>
                            <input type="radio" value="not-connected" name="radio-connecting-communication" id="not-connected"
                                   class="btn-check" />
                            <label for="not-connected" class="btn btn-outline-primary">Не установленно</label>
                            <input type="radio" value="part-connected" name="radio-connecting-communication" id="part-connected"
                                   class="btn-check" />
                            <label for="part-connected" class="btn btn-outline-primary">Частично установленно</label>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col">
                <label class="form-lable">Текущее использование</label>
                <div class="row">
                    <div class="col">
                        <div class="btn-group" role="group">
                            <input type="radio" value="living-space" name="radio-current-use" id="living-space"
                                   class="btn-check" />
                            <label for="living-space" class="btn btn-outline-primary">Жилая</label>
                            <input type="radio" value="uninhabited-premise" name="radio-current-use" id="uninhabited-premise"
                                   class="btn-check" />
                            <label for="uninhabited-premise" class="btn btn-outline-primary">Нежилая</label>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Слаботочное обеспечение</label>
                <div class="row">
                    <div class="col">
                        <div role="group">
                            <input type="checkbox" class="btn-check" id="tv" />
                            <label for="tv" style="margin-right:7px" class="btn btn-outline-primary">ТВ</label>
                            <input type="checkbox" class="btn-check" id="radio" />
                            <label for="radio" style="margin-right:7px" class="btn btn-outline-primary">Радио</label>
                            <input type="checkbox" class="btn-check" id="phone" />
                            <label for="phone" style="margin-right:7px" class="btn btn-outline-primary">Телефон</label>
                            <input type="checkbox" class="btn-check" id="internet" />
                            <label for="internet" style="margin-right:7px" class="btn btn-outline-primary">Интернет</label>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Выводы по правоустанавливающим документам</label>
                <div class="row">
                    <div class="col">
                        <div class="btn-group" role="group">
                            <input type="radio" value="respond" name="radio-conclusion-document" id="respond"
                                   class="btn-check" />
                            <label for="respond" class="btn btn-outline-primary">Соответствуют</label>
                            <input type="radio" value="not-respond" name="radio-conclusion-document" id="not-respond"
                                   class="btn-check" />
                            <label for="not-respond" class="btn btn-outline-primary">Не соответствуют</label>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!--
    Иная информация
    -->
        <div class="row">
            <div class="col">
                <label class="form-lable">Имущественные права</label>
                <select class="form-select"></select>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Сведения о правообладателе(-лях)</label>
                <div class="row">
                    <div class="col">
                        <label class="form-lable">ФИО/Наименование организации (1)</label>
                        <input class="form-control" type="text" />
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <a class="btn btn-outline-primary" style="width:100%">Добавить собственика</a>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Источники информации</label>
                <textarea class="form-control" rows="5"></textarea>
            </div>
        </div>
    </div>
</template>