<template>
    <div class="container">
        <div class="row">
            <div class="col">
                <h5>Местоположение объекта оценки</h5>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Адрес объекта оценки</label>
                <input class="form-control" type="text" />
            </div>
        </div>
        <div class="row">
            <div class="col">
                <div class="form-check">
                    <input class="form-check-input" type="checkbox" id="address-plate">
                    <label class="form-check-label" for="address-plate">
                        На доме отсутствует адресная табличка/не читается или отсутствует номер дома/название улицы
                    </label>
                </div>
                <div class="form-check">
                    <input class="form-check-input" type="checkbox" id="by-hand">
                    <label class="form-check-label" for="by-hand">
                        Указать адрес вручную согласно правоустанавливающих документов
                    </label>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Адрес согласно правоустанавливающих документов</label>
                <input class="form-control" type="text" />
            </div>
        </div>
        <div class="row">
            <div class="col">
                <div style="height:150px; background:#e1dede">
                    Тут будет карта
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Кадастровый номер</label>
                <input class="form-control" type="text" />
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Ближайшее метро/ж.д. станция/остановка общественного транспорта</label>
                <input class="form-control" type="text" />
            </div>
        </div>
        <div class="row align-items-end">
            <div class="col">
                <label class="form-lable">Время, минут</label>
                <input class="form-control" type="text" />
            </div>
            <div class="col">
                <div class="btn-group" role="group">
                    <input type="radio" value="OnFoot" name="radioAccess" id="OnFoot"
                           class="btn-check" />
                    <label for="OnFoot" class="btn btn-outline-primary">Пешком</label>
                    <input type="radio" value="OnTransport" name="radioAccess" id="OnTransport"
                           class="btn-check" />
                    <label for="OnTransport" class="btn btn-outline-primary">Транспорт</label>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Обеспеченность общественным транспортом</label>
                <div class="row">
                    <div class="col">
                        <div class="btn-group" role="group">
                            <input type="radio" value="acceptable" name="radio-availability-transport" id="acceptable"
                                   class="btn-check" />
                            <label for="acceptable" class="btn btn-outline-primary">Удовл.</label>
                            <input type="radio" value="unacceptable" name="radio-availability-transport" id="unacceptable"
                                   class="btn-check" />
                            <label for="unacceptable" class="btn btn-outline-primary">Неудовл.</label>
                            <input type="radio" value="sufficient" name="radio-availability-transport" id="sufficient"
                                   class="btn-check" />
                            <label for="sufficient" class="btn btn-outline-primary">Хорошее</label>
                            <input type="radio" value="excellent" name="radio-availability-transport" id="excellent"
                                   class="btn-check" />
                            <label for="excellent" class="btn btn-outline-primary">Отличное</label>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Ближайшая транспортная магистраль</label>
                <input class="form-control" type="text" />
            </div>
            <div class="col-3">
                <label class="form-lable">Расстояние, километр</label>
                <input class="form-control" type="text" />
            </div>
        </div>

        <!--
    Блок-2: Окружение
    -->
        <div class="row">
            <div class="col">
                <h6>Окружение</h6>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Преобладающая застройка района</label>
                <select class="form-select"></select>
            </div>
            <div class="col">
                <label class="form-lable">Плотность застройки</label>
                <select class="form-select"></select>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Объекты социальной инфраструктуры</label>
                <div class="row">
                    <div class="col">
                        <div role="group">
                            <input type="checkbox" class="btn-check" id="school" />
                            <label for="school" style="margin-right:7px" class="btn btn-outline-primary">Школа</label>
                            <input type="checkbox" class="btn-check" id="kindergarten" />
                            <label for="kindergarten" style="margin-right:7px" class="btn btn-outline-primary">Детский сад</label>
                            <input type="checkbox" class="btn-check" id="servicelife" />
                            <label for="servicelife" style="margin-right:7px" class="btn btn-outline-primary">Предприятия службы быта</label>
                            <input type="checkbox" class="btn-check" id="pharmacy" />
                            <label for="pharmacy" style="margin-right:7px" class="btn btn-outline-primary">Аптека</label>
                            <input type="checkbox" class="btn-check" id="polyclinic" />
                            <label for="polyclinic" style="margin-right:7px" class="btn btn-outline-primary">Поликлиника</label>
                            <input type="checkbox" class="btn-check" id="store" />
                            <label for="store" style="margin-right:7px" class="btn btn-outline-primary">Торговые предприятия</label>
                            <input type="checkbox" class="btn-check" id="bank" />
                            <label for="bank" class="btn btn-outline-primary">Банки, банкоматы</label>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Обеспеченность инфраструктурой</label>
                <select class="form-select"></select>
            </div>
            <div class="col">
                <label class="form-lable">Престижность района</label>
                <select class="form-select"></select>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Объекты промышленной инфраструктуры</label>
                <select class="form-select"></select>
            </div>
            <div class="col">
                <label class="form-lable">Экологическая обстановка</label>
                <select class="form-select"></select>
            </div>
        </div>

        <!--
    Блок-3: Дом и территория
    -->
        <div class="row">
            <div class="col">
                <h6>Дом и территория</h6>
            </div>
            <div class="col-3">
                <a class="btn btn-success"
                   style="float:right">
                    Найти на reformaghk.ru
                </a>
            </div>
            <div class="col-3">
                <a class="btn btn-success"
                   style="float:right">
                    Найти на dom.mirghk.ru
                </a>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Жилой комплекс</label>
                <input class="form-control" type="text" />
            </div>
        </div>
        <div class="row align-items-end">
            <div class="col">
                <label class="form-lable">Год постройки</label>
                <input class="form-control" type="number" />
            </div>
            <div class="col">
                <label class="form-lable">Материал стен</label>
                <select class="form-select"></select>
            </div>
            <div class="col">
                <a class="btn btn-primary">Расчиталь износ</a>
            </div>
            <div class="col">
                <label class="form-lable">Износ, %</label>
                <input class="form-control" type="text" />
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Тип здания</label>
                <div class="row">
                    <div class="col">
                        <div class="btn-group" role="group">
                            <input type="radio" value="tenement-house" name="radio-building" id="tenement-house"
                                   class="btn-check" />
                            <label for="tenement-house" class="btn btn-outline-primary">Жилой дом</label>
                            <input type="radio" value="apart-hotel" name="radio-building" id="apart-hotel"
                                   class="btn-check" />
                            <label for="apart-hotel" class="btn btn-outline-primary">Апарт-отель</label>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col">
                <label class="form-lable">Серия дома</label>
                <input class="form-control" type="text" />
            </div>
            <div class="col">
                <label class="form-lable">Число этажей</label>
                <input class="form-control" type="text" />
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Метериал перекрытий</label>
                <select class="form-select"></select>
            </div>
            <div class="col">
                <label class="form-lable">Состояние дома</label>
                <select class="form-select"></select>
            </div>
        </div>
        <div class="row align-items-end">
            <div class="col">
                <label class="form-lable">Капитальный ремонт</label>
                <div class="row">
                    <div class="col">
                        <div class="btn-group" role="group">
                            <input type="radio" value="produced" name="radio-overhaul" id="produced"
                                   class="btn-check" />
                            <label for="produced" class="btn btn-outline-primary">Производился</label>
                            <input type="radio" value="not-produced" name="radio-overhaul" id="not-produced"
                                   class="btn-check" />
                            <label for="not-produced" class="btn btn-outline-primary">Не производился</label>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col">
                <label class="form-lable">Год капитального ремонта</label>
                <input class="form-control" type="text" />
            </div>
            <div class="col">
                <input type="checkbox" value="not-value" name="checkbox-value" id="not-value"
                       class="btn-check" />
                <label for="not-value" class="btn btn-outline-primary">Нет данных</label>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Планы на снос/реконструкцию</label>
                <select class="form-select"></select>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Описание сноса/реконструкции</label>
                <textarea class="form-control" rows="5"></textarea>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Объекты социальной инфраструктуры</label>
                <div class="row">
                    <div class="col">
                        <div role="group">
                            <input type="checkbox" class="btn-check" id="elevator" />
                            <label for="elevator" style="margin-right:7px" class="btn btn-outline-primary">Лифт</label>
                            <input type="checkbox" class="btn-check" id="garbage-chute" />
                            <label for="garbage-chute" style="margin-right:7px" class="btn btn-outline-primary">Мусоропровод</label>
                            <input type="checkbox" class="btn-check" id="intercom" />
                            <label for="intercom" style="margin-right:7px" class="btn btn-outline-primary">Домофон</label>
                            <input type="checkbox" class="btn-check" id="video-surveillance" />
                            <label for="video-surveillance" style="margin-right:7px" class="btn btn-outline-primary">Видеонаблюдение</label>
                            <input type="checkbox" class="btn-check" id="concierge" />
                            <label for="concierge" style="margin-right:7px" class="btn btn-outline-primary">Консьерж</label>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col">
                <label class="form-lable">Состояние зон подъезда</label>
                <div class="row">
                    <div class="col">
                        <div class="btn-group" role="group">
                            <input type="radio" value="acceptable" name="radio-entrance-area" id="acceptable-entrance-area"
                                   class="btn-check" />
                            <label for="acceptable-entrance-area" class="btn btn-outline-primary">Удовл.</label>
                            <input type="radio" value="unacceptable" name="radio-entrance-area" id="unacceptable-entrance-area"
                                   class="btn-check" />
                            <label for="unacceptable-entrance-area" class="btn btn-outline-primary">Неудовл.</label>
                            <input type="radio" value="sufficient" name="radio-entrance-area" id="sufficient-entrance-area"
                                   class="btn-check" />
                            <label for="sufficient-entrance-area" class="btn btn-outline-primary">Хорошее</label>
                            <input type="radio" value="excellent" name="radio-entrance-area" id="excellent-entrance-area"
                                   class="btn-check" />
                            <label for="excellent-entrance-area" class="btn btn-outline-primary">Отличное</label>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Электроснабжение</label>
                <select class="form-select"></select>
            </div>
            <div class="col">
                <label class="form-lable">Холодное водоснабжение</label>
                <select class="form-select"></select>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Горячее водоснабжение</label>
                <select class="form-select"></select>
            </div>
            <div class="col">
                <label class="form-lable">Газоснабжение</label>
                <select class="form-select"></select>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Водоотведение</label>
                <select class="form-select"></select>
            </div>
            <div class="col">

            </div>
        </div>
        <div class="row">
            <div class="col">
                <label class="form-lable">Придомовая территория</label>
                <div class="row">
                    <div class="col">
                        <div role="group">
                            <input type="checkbox" class="btn-check" id="spontaneous-parking" />
                            <label for="spontaneous-parking" style="margin-right:7px" class="btn btn-outline-primary">Стихийная парковка</label>
                            <input type="checkbox" class="btn-check" id="organized-guarded-parking" />
                            <label for="organized-guarded-parking" style="margin-right:7px" class="btn btn-outline-primary">Организованная охраняемая парковка</label>
                            <input type="checkbox" class="btn-check" id="underground-parking" />
                            <label for="underground-parking" style="margin-right:7px" class="btn btn-outline-primary">Подземная парковка</label>
                            <input type="checkbox" class="btn-check" id="not-fenced" />
                            <label for="not-fenced" style="margin-right:7px" class="btn btn-outline-primary">Не огорожена</label>
                            <input type="checkbox" class="btn-check" id="fenced-territory" />
                            <label for="fenced-territory" style="margin-right:7px" class="btn btn-outline-primary">Огороженная территория</label>
                            <input type="checkbox" class="btn-check" id="fenced-territory-checkpoint" />
                            <label for="fenced-territory-checkpoint" style="margin-right:7px" class="btn btn-outline-primary">Огороженная территория и КПП</label>
                            <input type="checkbox" class="btn-check" id="asphalt-pavement" />
                            <label for="asphalt-pavement" style="margin-right:7px" class="btn btn-outline-primary">Асфальтовое покрытие</label>
                            <input type="checkbox" class="btn-check" id="children-playground" />
                            <label for="children-playground" style="margin-right:7px" class="btn btn-outline-primary">Детская площадка</label>
                            <input type="checkbox" class="btn-check" id="fenced-protected-territory" />
                            <label for="fenced-protected-territory" style="margin-right:7px" class="btn btn-outline-primary">Огороженная и охраняемая территория</label>
                        </div>
                    </div>
                </div>
            </div>
        </div>


    </div>
</template>