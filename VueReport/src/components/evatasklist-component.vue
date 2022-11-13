<template>
    <div class="container">

        <div class="row align-items-center">
            <div class="col-md-6">
                <h3>Заявки на оценку</h3>
            </div>
            <div class="col-md-6">
                <a class="btn btn-primary">Новая заявка</a>
            </div>
        </div>

        <div class="row">
            <div class="col-lg-12">
                <div class="table-responsive">
                    <tabel class="table project-list-table table-nowrap align-middle table-borderless">
                        <thead>
                            <tr>
                                <th scope="col">Номер заявки</th>
                                <th scope="col">Дата заявки</th>
                                <th scope="col">Дата составления</th>
                                <th scope="col">Заказчик</th>
                                <th scope="col">Оценщик</th>
                                <th>Статус</th>
                                <th scope="col" style="width: 200px;"></th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>
                                    0458
                                </td>
                                <td>
                                    21.05.2021
                                </td>
                                <td>
                                    25.07.2021
                                </td>
                                <td>
                                    Сергеенко Иван Павлович
                                </td>
                                <td>
                                    Федотов Андрей Карлович
                                </td>
                                <td>
                                    Подписан
                                </td>
                                <td></td>
                            </tr>
                        </tbody>
                    </tabel>
                </div>
            </div>
        </div>

        <div class="row align-items-center">
            <div class="col-sm-6">
                <div>
                    <p class="mb-sm-0">Showing 1 to 10 of 57 entries</p>
                </div>
            </div>
            <div class="col-sm-6">
                <div class="float-sm-end">
                    <ul class="pagination mb-sm-0">
                        <li class="page-item disabled">
                            <a href="#" class="page-link">
                                Назад
                            </a>
                        </li>
                        <li class="page-item active"><a href="#" class="page-link">1</a></li>
                        <li class="page-item"><a href="#" class="page-link">2</a></li>
                        <li class="page-item"><a href="#" class="page-link">3</a></li>
                        <li class="page-item">
                            <a href="#" class="page-link">Далее</a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    name: 'evatasklist-component',
    data() {
        return {
            email: 'mymail@mail.ru',
            password: '12345678',
            isCustomer: false
        }
    },
    methods: {
        emailInput(value) {
            this.email = value
        },
        passwordInput(value) {
            this.password = value
        }
    }
}
</script>